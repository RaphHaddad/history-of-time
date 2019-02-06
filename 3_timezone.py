from datetime import datetime, timedelta
from dateutil import tz

samoa_tz = tz.gettz('Pacific/Apia')
a_date = datetime(2011, 12, 29, tzinfo=samoa_tz)

a_date_as_utc = a_date.astimezone(tz.UTC)
a_date_as_utc += timedelta(days=1)

print(a_date_as_utc.astimezone(samoa_tz))