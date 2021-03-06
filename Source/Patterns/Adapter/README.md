# Adapter Pattern
## When to use?
The "friendly name" for an adapter is a "wrapper object", and thus:
- Whenever you have a class, module, or API that would be useful but doesn't match (implement) the interface you require.
- You are designing a class, module, framework or API and you want to ensure it is usable by a wide variety of classes and applications.
* Note, see related patterns below.

### Wait a minute - do you have an example?
Ok, so imagine a standard power plug and the power outlets and the differences between US and Europe.. In between the plug and the outlet sits and "adapter" to let a US plug work with the european outlet.
The **intent** of the adapter is to convert the interface of a class into another interface the clients expect. This way it allows classes to work together that couldn't otherwise due to incompatible interfaces. It also makes client implementations "future proof", by letting them depend on adapter interfaces rather than concrete classes directly. When the underlying implementation changes for example, the client code relying on the adapter doesn't need to know about it, nor does it have to change. Aha, isn't that a good way to achieve the **open/closed principle**? Yes indeed!

### So, use it when...
- You cant to use an existing class, but it's interface doesn't match the one you require.
- You want to create a reusable class that cooperates with unrelated or unforeseen classes.
- You need to use several existing subclasses, but it's impractical to adapt their interface by subclassing each and every one.

### Real world examples
- ADO.NET's `IDataAdapter` with `DbDataAdapter` and it's related `OdbcDataAdapter`, `OleDbDataApeter`, `SqlClientDataAdapter` etc...

## Related pattersn
- Repository
- Strategy, as the adapter pattern is often passed into a class that depends on it, thus implementing the strategy pattern
- Fa�ade, as they're both **wrappers**. The Fa�ade however attempts to simplify the interface and often wraps **many** classes, while the adapter wraps a **single** adaptee and is not generally concerned with simplifying the interface.

## Resources & References
- https://app.pluralsight.com/library/courses/csharp-design-strategies/table-of-contents
- https://app.pluralsight.com/library/courses/principles-oo-design/table-of-contents
- https://app.pluralsight.com/library/courses/patterns-library/table-of-contents