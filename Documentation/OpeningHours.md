## Operating Hours

### Examples of how to configure the Operating Hours

*"We are open from 9AM to 5:30PM every weekday."*

    "OperatingHours" = [
	    {
	        "Day": "Weekdays",	    
	        "Open": {"Time": "0900"},   
	        "Close": {"Time": "1730"}
	    }
	]
    
*"On Saturday we are open from 9AM to 12:30PM, then we reopen in the evening from 6PM to 11PM."*

    "OperatingHours": [
	    {
	        "Day": "Saturday",	    
	        "Open": {"Time": "0900"},	    
	        "Close": {"Time": "1230"}
	    },
	    {
	        "Day": "Saturday",	    
	        "Open": {"Time": "1800"},	    
	        "Close": {"Time": "2300"}
	    }
	]

*"Every public holiday we are closed."*

    "OperatingHours": [
	    {
	        "Day": "Public Holidays",	    	    
	        "Close": {"AllDay": true}
	    }]

*"On the 1st of April this year we are having our Grand Opening."*

    "OperatingHours" = [
	    {
	        "Date": {"Day": 1, "Month": 4, "Year": 2019},   	    
	        "Open": {"Time": "0900"},
	        "Close": {"Time": "1800"},
	        "Comments": "Grand Opening"
	     }
	]
*"We never close."*

    "OperatingHours" = [
	    {
	        "Day": "Every Day",   	    
	        "Open": {"AllDay": true}
	     }
	]