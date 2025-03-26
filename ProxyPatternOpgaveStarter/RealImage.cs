using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatternOpgaveStarter
{
    // Concrete implementation of Image
    class RealImage : IImage
    {
        private String filename;

        public RealImage(String filename)
        {
            this.filename = filename;
            loadFromDisk();
        }

        private void loadFromDisk()
        {
            Console.WriteLine("Loading image " + filename);
        }

        public void Display()
        {
            Console.WriteLine("Displaying image " + filename);
        }
    }
}
