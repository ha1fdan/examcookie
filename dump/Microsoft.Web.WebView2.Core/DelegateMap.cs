using System;
using System.Collections.Generic;

namespace Microsoft.Web.WebView2.Core
{
	internal class DelegateMap
	{
		private Dictionary<String, HashSet<Int32>> _RegisteredHandlerIdsMap = new Dictionary<String, HashSet<Int32>>();

		private Dictionary<Int32, DelegateMap.tuple> _HandlerMap = new Dictionary<Int32, DelegateMap.tuple>();

		public DelegateMap()
		{
		}

		public Delegate GetDelegate(Int32 handlerId)
		{
			Delegate item;
			try
			{
				item = this._HandlerMap.get_Item(handlerId).handler;
			}
			catch (Exception exception)
			{
				item = null;
			}
			return item;
		}

		public List<String> GetRegisteredEventNameById(Int32 handlerId)
		{
			List<String> list = new List<String>();
			foreach (KeyValuePair<String, HashSet<Int32>> keyValuePair in this._RegisteredHandlerIdsMap)
			{
				if (!keyValuePair.get_Value().Contains(handlerId))
				{
					continue;
				}
				list.Add(keyValuePair.get_Key());
			}
			return list;
		}

		public Boolean InsertDelegate(String eventName, Int32 handlerId, Delegate handler)
		{
			Boolean flag;
			try
			{
				if (!this._RegisteredHandlerIdsMap.ContainsKey(eventName))
				{
					this._RegisteredHandlerIdsMap.set_Item(eventName, new HashSet<Int32>());
				}
				HashSet<Int32> item = this._RegisteredHandlerIdsMap.get_Item(eventName);
				if (!item.Contains(handlerId))
				{
					item.Add(handlerId);
					if (!this._HandlerMap.ContainsKey(handlerId))
					{
						this._HandlerMap.set_Item(handlerId, new DelegateMap.tuple(1, handler));
					}
					else
					{
						this._HandlerMap.get_Item(handlerId).count++;
					}
					flag = true;
				}
				else
				{
					flag = false;
				}
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				if (exception.get_InnerException() == null)
				{
					throw exception;
				}
				throw exception.get_InnerException();
			}
			return flag;
		}

		public Delegate RemoveDelegate(String eventName, Int32 handlerId)
		{
			Delegate @delegate;
			try
			{
				if (this._RegisteredHandlerIdsMap.ContainsKey(eventName))
				{
					HashSet<Int32> item = this._RegisteredHandlerIdsMap.get_Item(eventName);
					if (item.Remove(handlerId))
					{
						if (item.get_Count() == 0)
						{
							this._RegisteredHandlerIdsMap.Remove(eventName);
						}
						DelegateMap.tuple _tuple = this._HandlerMap.get_Item(handlerId);
						_tuple.count--;
						if (_tuple.count == 0)
						{
							this._HandlerMap.Remove(handlerId);
						}
						@delegate = _tuple.handler;
					}
					else
					{
						@delegate = null;
					}
				}
				else
				{
					@delegate = null;
				}
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				if (exception.get_InnerException() == null)
				{
					throw exception;
				}
				throw exception.get_InnerException();
			}
			return @delegate;
		}

		private class tuple
		{
			public Int32 count;

			public Delegate handler;

			public tuple(Int32 count, Delegate handler)
			{
				this.count = count;
				this.handler = handler;
			}
		}
	}
}