namespace Loops_Assignment
{
	class BeerSong
	{
		// Method to sing the song starting from the specified number of bottles
		public void SingSong(int bottles)
		{
			// Loop from the number of bottles down to 1
			for (int i = bottles; i >= 1; i--)
			{
				// Check if there is more than 1 bottle left
				if (i > 1)
				{
					// Print the verses for more than 1 bottle
					Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer. Take one down and pass it around, {i - 1} bottles of beer on the wall.");
				}
				else
				{
					// Print the verse for the last bottle
					Console.WriteLine($"{i} bottle of beer on the wall, {i} bottle of beer. Take one down and pass it around, no more bottles of beer on the wall.");
				}
			}
			// Final line when no bottles are left
			Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer. Go to the store and buy some more");

		}

		internal class Program
		{
			static void Main(string[] args)
			{
				// Create an instance of the BeerSong class
				BeerSong beerSong = new BeerSong();

				// Call the SingSong method to start singing with 99 bottles
				beerSong.SingSong(99); 

			}
		}
	}
}
