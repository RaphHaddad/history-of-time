from datetime import datetime
from dateutil import tz
from calendar import monthrange

sydney_tz = tz.gettz('Australia/Sydney')
payment_canceled_date = datetime(2019, 2, 15, tzinfo=sydney_tz)
cost_per_month = 50.0

last_day = monthrange(payment_canceled_date.year, payment_canceled_date.month)[1]
start_billing_cycle = datetime(payment_canceled_date.year, payment_canceled_date.month, 1, tzinfo=sydney_tz)
end_billing_cycle = datetime(payment_canceled_date.year, payment_canceled_date.month, last_day, tzinfo=sydney_tz)

cost_per_day = cost_per_month / ((end_billing_cycle - start_billing_cycle).days)
total_to_refund = cost_per_day * ((payment_canceled_date - start_billing_cycle).days)

## TODO: API call to refund 
print (total_to_refund)