namespace fishingContest
{
	abstract class Fish
	{
		public abstract int Mult();

		public virtual bool IsBream()
		{
			return false;
		}

        public virtual bool IsCarp()
        {
            return false;
        }

        public virtual bool IsCatfish()
        {
            return false;
        }
    }

    class Bream : Fish
    {
        private Bream() { }
        private static Bream instance;

        public static Bream Instance()
        {
            instance ??= new Bream();

            return instance;
        }

        public override int Mult()
        {
            return 2;
        }

        public override bool IsBream()
        {
            return true;
        }
    }

    class Carp : Fish
    {
        private Carp() { }
        private static Carp instance;

        public static Carp Instance()
        {
            //instance ??= new Carp();
            if (instance == null) instance = new Carp();

            return instance;
        }

        public override int Mult()
        {
            return 1;
        }

        public override bool IsCarp()
        {
            return true;
        }
    }

    class Catfish : Fish
    {
        private Catfish() { }
        private static Catfish instance;

        public static Catfish Instance()
        {
            instance ??= new Catfish();

            return instance;
        }

        public override int Mult()
        {
            return 3;
        }

        public override bool IsCatfish()
        {
            return true;
        }
    }
}

