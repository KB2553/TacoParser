namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();

        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ',' - Done
            var cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong - Done
            if (cells.Length < 3)
            {
                // Log that and return null
                logger.LogError("Less than 3 items in input");
                // Do not fail if one record parsing fails, return null
                return null; // TODO Implement
            }

            // grab the latitude from your array at index 0 (parse your string as a `double`) -Done
            var lat = double.Parse(cells[0]);
            // grab the longitude from your array at index 1 (parse your string as a `double`) - Done
            var longitude = double.Parse(cells[1]);
            // grab the name from your array at index 2 - Done
            var name = cells[2];
            // Your going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`

            // You'll need to create a TacoBell class - Done
            // that conforms to ITrackable - Done

            // Create a Point instance using the lat and longitude
            var locationPoint = new Point();
            locationPoint.Latitude = lat;
            locationPoint.Longitude = longitude;

            // Then, you'll need an instance of the TacoBell class
            // With the name and point set correctly

            var tacoBell = new TacoBell();
            tacoBell.Name = name;
            tacoBell.Location = locationPoint;

            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable

            return tacoBell;
        }
    }
}