from datetime import datetime, timedelta
from dateutil import tz

samoa_tz = tz.gettz('Pacific/Apia')
a_date = datetime(2011, 12, 29, tzinfo=samoa_tz)
print(a_date.isoformat())
a_date = a_date + timedelta(days=1)
print(a_date.isoformat())