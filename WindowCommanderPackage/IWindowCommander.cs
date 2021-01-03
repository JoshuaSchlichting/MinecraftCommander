
namespace WindowCommanderPackage
{
	public interface IWindowCommander
	{
		public void SendString(string str);
		public void SendKey(KeyEnum keyType);
	}
}
