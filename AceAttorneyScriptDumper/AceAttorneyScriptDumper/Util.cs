using System;
using System.IO;

namespace AceAttorneyScriptDumper {
	public static class Util {
		public static UInt16 SwapEndian( this UInt16 x ) {
			return x = (UInt16)( ( x << 8 ) |
			                     ( x >> 8 ) );
		}

		public static UInt32 SwapEndian( this UInt32 x ) {
			return x = ( x << 24 ) |
			          ( ( x << 8 ) & 0x00FF0000 ) |
			          ( ( x >> 8 ) & 0x0000FF00 ) |
			           ( x >> 24 );
		}

		public static uint ReadUInt32( this Stream s ) {
			int b1 = s.ReadByte();
			int b2 = s.ReadByte();
			int b3 = s.ReadByte();
			int b4 = s.ReadByte();

			return (uint)( b4 << 24 | b3 << 16 | b2 << 8 | b1 );
		}

		public static ushort ReadUInt16( this Stream s ) {
			int b1 = s.ReadByte();
			int b2 = s.ReadByte();

			return (ushort)( b2 << 8 | b1 );
		}

	}
}
