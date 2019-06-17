# TrafficLightSystemFYP
Traffic Light System at Road Junction made for Final Year Project


The main purpose of this project is to make a simulation of a traffic light system that is able to reduce congestion during peak hours.
The simulation is made using **Unity** and the script is written in **C#** programming language.

## How it works:

Within each state there are 3 forms of camera placements which are a top down view of the cross jucntion, a corner camera with a wide view of the juction and a free roaming camera which can be moved around by using the “W”,”A”,”S” and “D” key.

-Top Down View Camera
![Top down View](https://i.imgur.com/Ft6ZSYG.jpg)
-Corner View Camera
![Corner View](https://i.imgur.com/oGNa6sK.jpg)
-Free Roaming Camera
![Free Roaming View](https://i.imgur.com/38KV7Qj.jpg)



There are 4 states in the game to represent different situation of traffic. 

1. **Normal Case**

![Normal Case](https://i.imgur.com/GiOnDDv.jpg)

In this normal case, the users are able to observe the overview of the traffic light control system, how it will react when vehicles on the lane, how the system change the lane of the green light and etc. The simulation will show the normal case with minimum number of anomalies such as skipping lanes, no vehicles on the road, or etc.
  
2. **Skip Lane**

![Skip Lane Left Moving](https://i.imgur.com/if8OFn8.jpg)

  In the case above, the green light will start on the west side of road and will switch to the other lane in an anti-clockwise manner. Although the next lane is supposed to be the bottom lane, the bottom lane has no vehicle detected. Therefore, the current lane will skip the bottom lane’s green light and straight to the right lane’s green light.
  
  ![Skip Lane Right Moving](https://i.imgur.com/CQHwTLK.jpg)
  
3. **Extended Time**

![Extended Time](https://i.imgur.com/hYPG0M3.jpg)

  The figure above shows the non-stop coming of cars from the left lane thus increasing the green light time of the left lane. The initial time for green light is 6 seconds, and when a car is detected it will stop decrementing. However there will be another time, timer2, that is set 30 seconds every time the traffic lights turns green. Timer2 will continuously decrement every seconds. When timer2 reaches 0 seconds, it will set the original timer to 2 seconds. This is to ensure the time extended for that lane does not exceed 30 seconds. When the original timer is 2 seconds or less, this will turn the green light to yellow light.

![Extending Lane Yellow Light](https://i.imgur.com/vDUgsg2.jpg)

  Then the traffic light will turn from yellow light to red light and switch to green to the next lane and the same timer system will be implemented as well. This system will cycle throughout all the 4 lanes.
  
  ![Extended Time Red Light](https://i.imgur.com/XhzmeRc.jpg)
  
  ![Extened Time Next Lane Moving](https://i.imgur.com/fjA1dNu.jpg)
  
4. **No Car**
  
  ![No Car](https://i.imgur.com/6lloV2y.jpg)
  
  ![No Car Green Light](https://i.imgur.com/4Z2Fl8h.jpg)
  
  Then the traffic light will turn from yellow light to red light and switch to green to the next lane and the same timer system will be implemented as well. This system will cycle throughout all the 4 lanes.
