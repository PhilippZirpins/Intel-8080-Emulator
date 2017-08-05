using System;

namespace Intel8080Emulator
{
	public struct Register
	{
		UInt32 w;					//Access it as a double 16-bit register
		UInt16 x;

		struct b {					//accessed as two single byte registers
			uint l,h;				//low (l) and high (h) bytes of the register
			UInt16 pad;				//Little endian padding
		};
	}
}

