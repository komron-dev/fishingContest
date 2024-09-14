using System;
namespace fishingContest
{
	class Contest
	{
		public string loc { get; }
		public Club cl = new();
		public List<Angler> anglers = new();

		public Contest(string l ) { loc = l; }

		public void Register(Angler a)
		{
			foreach (Angler angler in anglers)
			{
				if (angler.name == a.name) return;
			}

			if (cl.IsMember(a))
			{
				anglers.Add(a);
			} else
			{
                throw new InvalidOperationException("Angler is not a member of the club and cannot be registered.");
            }
		}

		public bool AllCatfish()
		{
			foreach (var angler in anglers)
			{
				if (!(angler.CatFish(this))) return false;
			}

			return true;
		}

		public double Point()
		{
			double sum = 0;
            foreach (var angler in anglers)
            {
                sum += angler.Points(this);
            }

			return sum;
        }
    }
}

