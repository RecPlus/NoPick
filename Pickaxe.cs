using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace RD
{
	public class Pickaxe : GlobalItem
	{
		
		public override void SetDefaults(Item item)
		{
     if(item.pick > 0){
	 item.pick = 0;
	 }		 
		}
	}
}
