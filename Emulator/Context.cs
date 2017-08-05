using System;

namespace Intel8080Emulator
{
	public struct Context
	{
		//AF used to store all flags in a single word
		internal Register AF;									//Register AF (Accumulator + Flags)
		internal Register BC;									//Register BC (B + C)
		internal Register DE;									//Register DE (D + E)
		internal Register HL;									//Register HL (H + L)

		internal UInt16 PC; 									//Program counter; points to the next instruction to be executed
		internal UInt16 SP; 									//Stack pointer; points to memory for data retrieval 
		//flags stored in different fields as opposed to the AF register ab
		internal UInt32 flagC; 									//Carry flag
		internal UInt32 flagZPS;								//Zero, Parity and negative flags
		internal UInt32 flagAc;									//Auxiliary Carry flag (4-bit carry)

		internal UInt32 halted; 								//is CPU in halt state
		internal UInt32 intEnabled;								//are interupts enabled
		internal UInt32 intPending;								//stores a pending interupt if there is one
		internal UInt16 intAddress;								//stores the start address for the inferupt handling routine
		internal UInt16 NMIAddress;								//stores the start address for the NMI routine
		internal UInt32 NMIPending;								//stores a pending NMI if there is one

		//uint *mainMemory;								//pointer to the main memory
		//struct readMemoryHandler *writeMemoryHandler	//list of memory handlers for reading
		//struct writeMemoryHandler *writeMemoryHandler	//list of memory handlers for writing
		//struct readIOHandler *readIOHandler			//list of IO handlers for reading
		//struct writeIOHandler *writeIOHandler			//list of IO handlers for writing

		///////////////////////////////////////////

		internal UInt32 numMemoryBanks;							//Number of memory banks (0 - 64)
		//void *pBankList;										//List of pointers to the bank memory regions

		internal UInt32 cycleCount;								//Number of executed cycles
		//UInt32 opcodeStatistics[256];							//Number of times an opcode has been executed
		//UInt32 tracePC[256];									//Stores the last 256 PCs
		internal UInt32 traceIndex;								//Last entry in the PC trace buffer
	}
}

