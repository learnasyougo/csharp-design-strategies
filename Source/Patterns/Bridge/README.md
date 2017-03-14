# Bridge Pattern

## What and when to use?
> Decouple an abstraction from it's implementation so the two can vary independently ~ GOF

- **Decouple abstract from implementation**: base class or interface has an implementation. In this case they're coupled together. Changes in the interface have to be made in the class, and changes in the class are going to affect the interface.
- **so the two can vary indepdently**: as said above, the abstraction and the implementation are tightly coupled. The **reason** to use the bridge pattern is so the two can vary indepently from each other, and no changes are needed on both ends. 

In essence we're going to abstract away the abstraction of the implementation. We throw in an extra level of abstraction.

### Real world examples
FAQ, Book and a Paper that each have a set of very different properties, but each share a `Print()` method. Each one implements print differently.
Each of them implements `IManuscript` which holds a `Print()` method signature. Ath this point there's **no need for a bridge pattern**.

But several months later, now the client has an extra need.. He wants to print the books backwards (why, god knows why).
You could now subclass each implementation of `IManuscript`, e.g.: `Book` > `BackwardsBook` and implement (override) the `Print()` method to print everything backwards... But that's cumbersome, **not the right way to do it!** Because you have to implement it for each and every implementation of `IManuscript`. And not only that, what if the client would want to print in different ways in the future.. Then the problem of sublassing even gets worse and grows each time. This is not maintainable.

**We need a new level of abstraction**, so that when `Print()` is called it itself uses some kind of printer or formatter, while still keeping the different implementation details of the different `Print()` methods. We need to create an abstraction for the implementation of formatting.

Thus we introducide the `IFormatter` interface that's used inside the `Print()` method. To make sure each and every `IManuscript` accepts an `IFormatter` we pass one in via the ctor, and thus need to make sure we make `IManuscript` into an asbtract class in stead of an interface. We do **change** the `Print()` signature to also accept a formatter, when it's null it'll use the default one, when it's not null it will use the one passed in. Still the `Print()` method keeps existing.




### So, use it when...

## Related patterns


## Resources & References
- https://app.pluralsight.com/library/courses/csharp-design-strategies/table-of-contents
- https://app.pluralsight.com/library/courses/principles-oo-design/table-of-contents
- https://app.pluralsight.com/library/courses/patterns-library/table-of-contents