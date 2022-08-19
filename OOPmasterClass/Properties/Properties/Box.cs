namespace Properties
{

	public class Box
	{
		internal int length;
		internal int height;
		internal int width;
		internal int volume;


		public void DisplayInfo()
		{
			System.Console.WriteLine($"Length: {length}, Height: {length}, Width: {width}\n" +
				$"Volume: {length} * {length} * {width} = {length * height * width}");
		}
	}
}
