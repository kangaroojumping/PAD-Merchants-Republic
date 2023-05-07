using System;

public class ResourceInventory
{
	public ResourceInventory()
	{
		int resourceTypes = 8;
		String[] resourceNames =
		{
			"Wood",
			"Wheat",
			"Sand",
			"Ore",
			"Land",
			"Labor",
			"Housing",
			"Food"
		};

		/*
			Resource types : int
				0 - Wood
				1 - Wheat
				2 - Sand
				3 - Ore
				4 - Land
				5 - Labor (Food and housing)
				6 - Housing (Wood and Land)
				7 - Food (Wheat)
		*/

		int[] resourcesHeld = new int[resourceTypes];

		void addResourceOfType(int type, int quantity)
		{
			resourcesHeld[type] += quantity;
		}

		void addResourceOfType(int type){ addResourceOfType(type, 1); }
		
		

		String listResource(int resource)
        {

        }

		String listResourceList(int[] resources)
        {
			
        }
	}
}
