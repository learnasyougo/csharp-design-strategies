# Strategy Pattern
**Using composition rather than using inheritance.**
> The strategy pattern defines a family of algorithms, encapsulates each one and makes them interchangable aka pluggable). The pattern makes the algorithms vary independently from the clients that use it (aka decoupling it). In other words the client doesn't have top change when the algorithm changes, or when an algorithm is added.

**Inheritance** works when behaviour is shared downwards. Hierarchies tend to fall apart when some behaviour is shared horizontally - but can't be done efficiently with intheritance without overcomplicating the design. The **strategy** pattern helps to solve this problem as mentioned above, by letting algorithms vary independently from the clients that use it. One has to extract the algorithms and implement strategies for these algorithms.

<img src="https://upload.wikimedia.org/wikipedia/commons/3/39/Strategy_Pattern_in_UML.png"/>

## Examples
### Ducks
In the ducks example we see inheritance being use first, then refactored to use behaviours via interfaces aka introducing the strategy pattern. And thirdly, one can see you don't need the classes anymore, because a `Duck` is being described by it's behaviours that are injected. On could still ofcourse make concrete classes, or maybe create a Factory to create specialised `Ducks` with differing behaviours.

## References
- https://en.wikipedia.org/wiki/Strategy_pattern
- https://www.youtube.com/watch?v=v9ejT8FO-7I