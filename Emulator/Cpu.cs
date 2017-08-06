namespace Intel8080Emulator.Emulator

{
	//This class contains the emulated CPU's state. This state will be altered by the instructions executed	
    public class Cpu
    {
		Context context = new Context();

		internal void run(){

			while (!context.halted) {
				
				/*
				while (executedCycles < cyclesToExecute) {
					opCode = memory[context.PC++];
					instruction = decode(opCode);
					execute(instruction);
				}
				*/
			}
		}
		/*
		main functions needed in the CPU:
		Init() initializes the CPU's datastructures
		Reset() puts flags and registers to default values, and puts PC and SP to start values so the CPU can start 
			executing
		Execute() starts the emulation of the CPU, must happen after Init() and reset, receives at least one 
			parameter: the number of cycles to execute before stopping the emulation; if the number is more or 
			less reached the function returns if the emulation was successfull or not
		Set/GetContext()
		ResetContext()
		InteruptSignal() signals hardware interupts, might require parameters if the CPU needs them, and must return
			something in response
		Stop()

		*/
	}
}
