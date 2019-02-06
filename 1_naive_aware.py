from datetime import datetime, date, tzinfo
from dateutil import tz

class DiaryEntry:
    def __init__(self, the_date, entry):
        self.entry = "Date: " + the_date.isoformat() + "\n" +entry

class Transaction:
    def __init__(self, sent_from, sent_to, amount, time_of_transaction):
        self.description = sent_from + " sent " + sent_to + " $" + str(amount) + " at: " + time_of_transaction.isoformat()

the_date = date(2019, 2, 19) # Naive date
entry = DiaryEntry(the_date, "Back2Base is good")
print(entry.entry)
print

aust_east = tz.gettz('Australia/Sydney')
the_date = datetime(2019, 2, 19, tzinfo=aust_east) # Aware date. Point in time
entry = DiaryEntry(the_date, "Back2Base is good")
print(entry.entry)
print

utc = tz.gettz('UTC')
the_date = datetime.now(utc) # Aware date. Point in time
transaction = Transaction("Bob", "Alice", 10, the_date) 
print(transaction.description)
print