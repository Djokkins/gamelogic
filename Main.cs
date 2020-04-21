using System;




namespace gamelogic
{
	public int remainingunitcount = 10;  //


	public class Main
	{
		gamelogic.Setup;
	}

	public class battle
	{
		void fight(territory t1, territory t2)
		{
	
		}
		void reinforce()
		{
			if (units > 0)
			{
				place_units();	
			}
		}
	
		void attack()
		{
			while (!endturn)
			{
	
			}
		}
	
		void chose_attackpower()
		{
			if (power <= remainingunitcount)
			{
				return remainingunitcount;
			}
			else return null;
		
		}
	}

}