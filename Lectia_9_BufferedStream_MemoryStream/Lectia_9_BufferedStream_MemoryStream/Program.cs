using System;
using System.IO;
using System.Diagnostics;

// EXEMPLU DE CITIRE BufferedStream si MemoryStream - comparare eficiente -
// BufferedStream are nevoie intotdeauna de o memorie de stocare
// dotnetfiddle.net -> testezi codul si o sa vezi ca buffered stream e mai eficient decat memorystream
// aparent aici in VS ar parea sa fie mai eficient memorystream for some reason
namespace Lectia_9_BufferedStream
{
	public class Program
	{
		public static void Main()
		{
			Stopwatch s = Stopwatch.StartNew();
			using (MemoryStream memory = new MemoryStream())
			using (BufferedStream stream = new BufferedStream(memory))
			{
				for (int i = 0; i <= 5000000; i++)
				{
					stream.WriteByte(5);
				}
			}
			s.Stop();
			Console.WriteLine("Time for buffered stream: " + s.Elapsed.Milliseconds);

			s = Stopwatch.StartNew();
			using (MemoryStream memory = new MemoryStream())
			{
				for (int i = 0; i <= 5000000; i++)
				{
					memory.WriteByte(5);
				}
			}
			s.Stop();
			Console.WriteLine("Time for memory stream: " + s.Elapsed.Milliseconds);

		}
	}
}
