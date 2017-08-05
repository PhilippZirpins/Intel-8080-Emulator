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

	}
}
