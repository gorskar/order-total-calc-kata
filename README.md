## Problem Description

The challenge is to calculate the order totals & the correct sales tax for each order in a collection of orders that have come from the CompletedOrders part of an e-commerce application.

The aim is to approach this kata by identifying a design pattern that will help you to complete it and gain familiarity with that pattern through the kata.

Which design pattern will you use to calculate the order totals & the correct sales tax for each order?


### User Story

Given a collection of orders for a ecommerce site when their order totals are calculated then the sales tax is calculated according to the rules governing the jurisdiction of the customer.

### Sales Tax and carrier rules

#### US: 
- In the US electronics are sold with a Federal Sales Tax of 5%
- In NY fossil fuels attract a state sales tax of 10%.
- In TX fossil fuels no state sales tax.

#### UK:
- VAT is levied at 5% for fuel and 20% for electronics.

#### France:
- DPD will not accept gas or batteries. 
- Sales tax is applied to all non-food items at 18%.

### Orders to be processed in this run

```
{
	"orders": [{
			"customer": {
				"id": 1,
				"country": "US",
				"state": "TX",
				"carrier":"Fedex"
			},
			"orderLines": [{
					"product": "Gas",
					"cost": 100
				},
				{
					"product": "TV",
					"cost": 200
				}
			]
		},
		{
			"customer": {
				"id": 2,
				"country": "US",
				"state": "NY",
				"carrier":"USPS"
			},
			"orderLines": [{
					"product": "Gas",
					"cost": 100
				},
				{
					"product": "TV",
					"cost": 200
				}
			]
		},
		{
			"customer": {
				"id": 3,
				"country": "UK",
				"state": "Lancs",
				"carrier":"Parcelforce"
			},
			"orderLines": [{
					"product": "Gas",
					"cost": 100
				},
				{
					"product": "TV",
					"cost": 200
				}
			]
		},
		{
			"customer": {
				"id": 4,
				"country": "FR",
				"state": "Paris",
				"carrier":"DPD"
			},
			"orderLines": [{
					"product": "Gas",
					"cost": 100
				},
				{
					"product": "TV",
					"cost": 200
				}
			]
		},
		{
			"customer": {
				"id": 5,
				"country": "FR",
				"state": "Paris",
				"carrier":"UPS"
			},
			"orderLines": [{
					"product": "Gas",
					"cost": 100
				},
				{
					"product": "TV",
					"cost": 200
				}
			]
		}
	]
}
```