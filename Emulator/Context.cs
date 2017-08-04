namespace Intel8080Emulator.Emulator
{
    public class Context
    {
        private int pc { private set; get; } //Program counter
        private int sp { private set; get; } //Stack pointer


        private bool halted { private set; get; } // Is CPU in halt-state?
    }
}






/*
typedef union
{
UINT32 w;  Access it as a double 16-bit register 
UINT16 w;
struct
{
UINT8 l, h; /* Low (l) and High (h) bytes of the register 
UINT16 pad; /* Little-Endian padding 
} b; /* Accessed as two single byte registers 
} i8080Reg;
struct i8080Context
{
    i8080Reg AF; /* Register AF (Accumulator + Flags) 
    i8080Reg BC; /* Register BC (B + C)
    i8080Reg DE; /* Register DE (D + E) 
    i8080Reg HL; /* Register HL (H + L) 
    UINT16 PC; /* Program Counter 
    UINT16 SP; /* Stack Pointer 
    UINT32 flagC; /* Carry flag *
    UINT32 flagZPS; /* Zero, Parity and Negative flags *
    UINT32 flagAc; /* Auxiliary Carry flag (4-bit carry) *
    UINT32 halted; /* CPU is in Halt state. *
    UINT32 intEnabled; /* Interrupts are enabled or disabled *
    UINT32 intPending; /* Stores if there is a pending interrupt *
    UINT16 intAddress; /* Stores the start address for the interrupt handling rutine *
    UINT16 NMIAddress; /* Stores the start address for the NMI rutine *
    UINT32 NMIPending; /* Stores if there is a pending nmi *
    UINT8* mainMemory; /* Pointer to the main memory *
    struct readMemoryHandler *readMemoryHandler; /* List of memory handlers for reading *
struct writeMemoryHandler *writeMemoryHandler; /* List of memory handlers for writing *
struct readIOHandler *readIOHandler; /* List of IO handlers for reading *
struct writeIOHandler *writeIOHandler; /* List of IO handlers for writing *
UINT32 numMemoryBanks; /* Number of banks of memory (0 - 64) *
    void* pBankList; /* List of pointers to the bank memory regions *
    UINT32 cycleCount; /* Number of executed cycles *
    UINT32 opcodeStatistics[256]; /* Number of times an opcode has been executed *
    UINT32 tracePC[256]; /* Stores the last 256 PCs
    UINT32 traceIndex; /* Last entry in the PC trace buffer *
};
Figure 5. CPU context structure(i8080 emulator).


*/