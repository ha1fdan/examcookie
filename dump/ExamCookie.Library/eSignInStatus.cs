using System;

namespace ExamCookie.Library
{
	public enum eSignInStatus
	{
		STUDENT_NOT_FOUND = 1,
		STUDENT_SIGNED_IN = 2,
		STUDENT_SIGNED_OUT = 3,
		EXAM_NOT_FOUND = 4,
		EXAM_TERMINATED = 5
	}
}