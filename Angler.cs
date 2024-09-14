using System;
namespace fishingContest
{
	class Angler
	{
		public string name { get; }
		public List<Catch> catches { get; }

		public Angler(string name)
		{
			this.name = name;
		}

		public void Catch(Fish f, double w, Contest c)
		{
			catches.Add(new Catch(f, w, c));
		}

		public double Points(Contest c)
		{
			double sum = 0;
			foreach(Catch item in catches) {
				if (c == item.contest)
				{
					sum += item.Value();
				}
			}

			return sum;
		}

		public bool CatFish(Contest c)
		{
			foreach (Catch item in catches)
			{
				if (item.fish.IsCatfish() && item.contest == c) return true;
			}
			return false;
		}
	}
}

