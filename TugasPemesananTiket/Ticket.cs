namespace TugasPemesananTiket
{
    public class Ticket
    {
        private string _name;
        private readonly ISeat _seat;
        private readonly FilmType _filmType;
        
        public Ticket(string name, ISeat seat, FilmType filmType)
        {
            _name = name;
            _seat = seat;
            _filmType = filmType;
        }
        
        public decimal CalculateTotalPrice()
        {
            return CalculateTotalPrice(_seat);
        }
        
        
        public decimal CalculateTotalPrice(params AdditionalService[] additionalServices)
        {
            return CalculateTotalPrice(_seat, additionalServices);
        }
        
        public decimal CalculateTotalPrice(ISeat seat, params AdditionalService[] additionalServices)
        {
            decimal additionalServicePrice = 0;
            if (additionalServices != null)
            {
                foreach (var additionalService in additionalServices)
                {
                    additionalServicePrice += additionalService.GetPrice();
                }
            }
            return seat.GetPrice() + additionalServicePrice;
        }
    }
}