using System;
namespace fishingContest
{
	class Club
	{
		public List<Angler> members = new();
		public List<Contest> contests = new();

		public Contest Organize(string l)
		{
			Contest contest = new(l);
			contests.Add(contest);
			return contest;
		}

		public void Enter(Angler a)
		{
			if (!IsMember(a))
			{
				members.Add(a);
            }
            else throw new InvalidOperationException("Angler is not a member of the club and cannot be entered.");
        }

		public Tuple<bool, Contest> Best()
		{
			bool l = false;
			double max = 0;
			Contest? con = null;
			foreach (Contest contest in contests)
			{
				if (!contest.AllCatfish()) continue;

				if (l)
				{
					if (contest.Point() > max)
					{
						max = contest.Point();
						con = contest;
					} 
				}
                else
                {
                    l = true;
					max = contest.Point();
					con = contest;
                }
            }

			return new Tuple<bool, Contest>(l, con);
		}

        public bool IsMember(Angler a)
		{
			foreach (Angler member in members)
			{
				if (member.name == a.name) { Console.WriteLine(a.name + member.name); return true; }
			}

			return false;
		}
	}
}

