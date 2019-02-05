from datetime import datetime, timedelta
from pytz import timezone

samoa_tz = timezone('Pacific/Apia')
a_date = datetime(2011, 12, 29, tzinfo=samoa_tz)
print(a_date.isoformat())
a_date = a_date + timedelta(1)
print(a_date.isoformat())