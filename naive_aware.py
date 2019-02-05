from datetime import datetime, date, tzinfo
from dateutil import tz

class DiaryEntry:
    def __init__(self, the_date, entry):
        self.entry = "Date: " + the_date.isoformat() + "\n" +entry

class Transaction:
    def __init__(self, sent_from, sent_to, amount, time_of_transaction):
        self.description = sent_from + " sent " + sent_to + " $" + str(amount) + " at: " + time_of_transaction.isoformat()

# Naive date
entry = DiaryEntry(date(2019, 2, 19), "Back2Base is good")
print(entry.entry)
print

# Aware date. Point in time
aust_east = tz.gettz('Australia/Sydney')
entry = DiaryEntry(datetime(2019, 2, 19, tzinfo=aust_east), "Back2Base is good")
print(entry.entry)
print

# Aware date. Point in time
utc = tz.gettz('UTC')
transaction = Transaction("Bob", "Alice", 10, datetime.now(utc)) 
print(transaction.description)
print