using System;

namespace ExamCookie.Library
{
	public enum eVirtualMachineType
	{
		NONE = 0,
		VMWARE = 1,
		VIRTUAL_PC = 2,
		VIRTUAL_BOX = 4,
		PARALLELS = 8
	}
}