using System;

namespace Objects
{
    public class ExchangeRateEntity
    {
	    private decimal _buyingRate;
	    private decimal _sellingRate;

	    public DateTime ExchangeRateDateTime;
		public decimal AverageRate;

		public decimal SellingRate
	    {
		    get
		    {
			    return _sellingRate;
		    }
		    set
		    {
			    _sellingRate = value >= 0 ? value : 0;
		    }
	    }	    

	    public decimal BuyingRate
	    {
		    get
		    {
			    return _buyingRate;
		    }
		    set
		    {
			    _buyingRate = value >= 0 ? value : 0;
		    }
	    }

	    public decimal CurrentSpread => BuyingRate - SellingRate;

	    public ExchangeRateEntity()
	    {
		    ExchangeRateDateTime = DateTime.Now;
	    }
    }
}
