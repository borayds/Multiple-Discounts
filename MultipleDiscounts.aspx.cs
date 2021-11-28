//// Coding to Find the Total Discounted Amount ($)
//// Let’s say the beginning amount is $200 and we apply 10%+10%+0% discount. So, coding with C#, we go step by step;

double AfterDiscount1 = Convert.ToDouble(BeginningAmount.Text) - (Convert.ToDouble(BeginningAmount.Text) * Convert.ToDouble(FirstPercentage.Text) * 0.01);
// AfterDiscount1 = 200-(200*10*0.01) = 200-(20) = $180 

double AfterDiscount2 = AfterDiscount1 - (AfterDiscount1 * Convert.ToDouble(SecondPercentage.Text) * 0.01);
// AfterDiscount2 = 180-(180*10*0.01) = 180-(18) = $162

double AfterDiscount3 = AfterDiscount2 - (AfterDiscount2 * Convert.ToDouble(ThirdPercentage.Text) * 0.01);
// AtferDiscount3 = 162-(162*0*0.01) = 162-(0) = $162 again..

//// Coding to Find the Total Discount Percantage Applied (%)
//// With the same percantage variables applied above (10%+10%+0%);

double TotalDiscountPercentage1 = 100 - 100 * (Convert.ToDouble(FirstPercentage.Text) * 0.01);
// TotalDiscountPercentage1 = 100-(100*10*0.01) = 100-(10) = 90%

double TotalDiscountPercentage2 = TotalDiscountPercentage1 - (TotalDiscountPercentage1 * Convert.ToDouble(SecondPercentage.Text) * 0.01)
// TotalDiscountPercentage2 = 90-(90*10*0.01) = 90-(9) = 81%
// (81% will be subtracted from 100% below to find the total discount percentage)

double TotalDiscountPercentage3 = 100 - (TotalDiscountPercentage2 - (TotalDiscountPercentage2 * Convert.ToDouble(ThirdPercentage.Text) * 0.01));
// TotalDiscountPercentage3 = 100-(81-(81*0*0.01)) = 100-(81-0) = 19%
