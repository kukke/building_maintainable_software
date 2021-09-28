using System.Collections.Generic;
using System.Drawing;

namespace eu.sig.training.ch03
{

    public class FlagFactory
    {
        // tag::getFlag[]
        public IList<Color> GetFlagColors(Nationality nationality)
        {
            Dictionary<Nationality, List<Color>> dictionary = new Dictionary<Nationality, List<Color>>();
            dictionary.Add(Nationality.DANISH, new List<Color> { Color.Red, Color.White, Color.Blue });
            dictionary.Add(Nationality.DUTCH, new List<Color> { Color.Black, Color.Red, Color.Yellow });
            dictionary.Add(Nationality.GERMAN, new List<Color> { Color.Black, Color.Red, Color.Yellow });
            dictionary.Add(Nationality.BELGIAN, new List<Color> { Color.Black, Color.Yellow, Color.Red });
            dictionary.Add(Nationality.FRENCH, new List<Color> { Color.Red, Color.White, Color.Blue });
            dictionary.Add(Nationality.ITALIAN, new List<Color> { Color.Red, Color.White, Color.Blue });
            dictionary.Add(Nationality.LUXEMBOURGER, new List<Color> { Color.Red, Color.White, Color.Blue });
            dictionary.Add(Nationality.UNCLASSIFIED, new List<Color> { Color.Red, Color.White, Color.Blue });

            if (!dictionary.ContainsKey(nationality))
                return dictionary[Nationality.UNCLASSIFIED];
            return dictionary[nationality];
        }
        // end::getFlag[]
    }

}
