using System;
namespace tpmodul4_1302223007
{
	public enum DoorState
	{
		Terkunci, Terbuka
	}

	public enum Trigger
	{
		KunciPintu, BukaPintu
	}

	public class DoorMachine
	{
		public class Transition
		{
			public DoorState stateAwal;
			public DoorState stateAkhir;
			public Trigger trigger;

			public Transition(DoorState stateAwal, DoorState stateAkhir, Trigger trigger)
			{
				this.stateAwal = stateAwal;
				this.stateAkhir = stateAkhir;
				this.trigger = trigger;
			}
		}

        Transition[] transisi =
            {
                new Transition(DoorState.Terkunci, DoorState.Terbuka, Trigger.BukaPintu),
                new Transition(DoorState.Terbuka, DoorState.Terkunci, Trigger.KunciPintu),
            };

        public DoorState currentState = DoorState.Terkunci;

        public DoorState GetNextState(DoorState stateAwal, Trigger trigger)
        {
            DoorState stateAkhir = stateAwal;

            for (int i = 0; i < transisi.Length; i++)
            {
                Transition perubahan = transisi[i];

                if (stateAwal == perubahan.stateAwal && trigger == perubahan.trigger)
                {
                    stateAkhir = perubahan.stateAkhir;
                }
            }

            return stateAkhir;
        }

		public void ActivateTrigger(Trigger trigger)
		{
			currentState = GetNextState(currentState, trigger);

			Console.WriteLine(currentState == DoorState.Terkunci ? "Pintu terkunci" : "Pintu tidak terkunci");
		}
    }
}

