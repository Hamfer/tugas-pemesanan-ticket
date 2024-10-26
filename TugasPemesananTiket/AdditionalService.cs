using System.ComponentModel;

namespace TugasPemesananTiket
{
    public enum AdditionalService
    {
        Food,
        Drink
    }
    
    public static class AdditionalServiceExtensions
    {
        public static decimal GetPrice(this AdditionalService additionalService)
        {
            switch (additionalService)
            {
                case AdditionalService.Food:
                    return 10000;
                case AdditionalService.Drink:
                    return 5000;
                default:
                    throw new InvalidEnumArgumentException();
            }
        }
    }
}