using System.Reflection;
using System.IO;

namespace CardPlacer
{
    public class csCardSelector
    {
        //spades (♠), hearts (♥), diamonds (♦) and clubs (♣)

        public enum enmCardSuit
        {
            clubs, diamonds, hearts, spades
        }
        public enum enmCardValue
        {
            Ace, c2, c3, c4, c5, c6, c7, c8, c9, c10, Jack, Queen, King
        }
    }
    public class csCardSource
    {
        public static readonly int CardWidth = 71;
        public static readonly int CardHeight = 96;

        Bitmap source { get; set; }
        Size CardSize { get; set; }

        public csCardSource()
        {
            CardSize = new Size(CardWidth, CardHeight);
            Stream cards = Assembly.GetAssembly(this.GetType()).GetManifestResourceStream(@"CardSelector\cards.jpg");
            source = new Bitmap(cards);
        }

        public Bitmap GetCard(csCardSelector.enmCardSuit suit, csCardSelector.enmCardValue value)
        {
            if (source == null)
            {
                // Handle the case where source is null
                // (e.g., throw an exception, return a default image, etc.)
                throw new InvalidOperationException("Image source is not initialized.");
            }
            //Bitmap ret = new Bitmap(CardSize.Width+24, CardSize.Height+32,source.PixelFormat);
            Bitmap ret = new Bitmap(CardSize.Width, CardSize.Height, source.PixelFormat);
            ret.SetResolution(source.HorizontalResolution, source.VerticalResolution);

            Rectangle section = new Rectangle(((int)value) * CardSize.Width, ((int)suit) * CardSize.Height, CardSize.Width, CardSize.Height);
            Graphics g = Graphics.FromImage(ret);
            g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);
            return ret;
        }

    }
}
