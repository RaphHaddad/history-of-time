from datetime import datetime, timedelta
from dateutil import tz

def print_date(the_date):
    print("Date: " + the_date.isoformat() + "\tAs UTC: " + the_date.astimezone(tz.UTC).isoformat())

aust_east = tz.gettz('Australia/Sydney')
the_date = datetime(2019, 4, 7, 2, 59, 59, tzinfo=aust_east) # Aware date. Point in time....or is it
the_date_as_utc = the_date.astimezone(tz.UTC)

print("Original UTC Date:")
print_date(the_date_as_utc)
the_date_as_utc  += timedelta(seconds=1)
print("\nOriginal UTC Date Plus One Second:")
print_date(the_date_as_utc)

print("\nOriginal Date:")
print_date(the_date)
the_date += timedelta(seconds=1)
print("\nOriginal Date Plus One Second:")
print_date(the_date)