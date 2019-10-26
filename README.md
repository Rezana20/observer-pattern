"# observer-pattern" 
This project illustrates the observer pattern. 

Scenario: 
We have an electronic store which stores products. We want to notify our user/customers whenever we receive a new product. 

Classes include: 
Subject: This allows observers to subscribe to changes to its inventory. It also sends an update once a new item is added. 
         The subject allows observers to subscribe to its inventory and allows observers to unsubscribe. 
Observer: This contains an update method which prints the new state of the inventory once an item has been added. 
