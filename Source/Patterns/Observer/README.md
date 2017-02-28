# Observer Pattern
**Observering changing states, without the one changing state needing to know all the *subscribers* up front.**
It's a **push** based pattern, meaning that the objects interested in the change of state don't bother asking the x-time, but the object being observed **notifies** the objects interested (aka the **subscribers**) when it's state has been changed.


<img src="https://upload.wikimedia.org/wikipedia/commons/thumb/8/8d/Observer.svg/750px-Observer.svg.png"/>

## Examples
### Thermometer being observed
Observering a class ´Thermometer´, where in the **polling** example the `LogTemperature` class needs to poll for new data without knowing whether the data has changed or not. The second example, with the **Observer** pattern introduces `IObserver` and `IObservable` and some implementation examples.

## References
- https://sourcemaking.com/design_patterns/observer
- https://en.wikipedia.org/wiki/Observer_pattern
- https://www.youtube.com/watch?v=_BpmfnqjgzQ