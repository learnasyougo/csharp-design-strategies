# Adapter Pattern
## When to use?
The "friendly name" for an adapter is a "wrapper object", and thus:
- Whenever you have a class, module, or API that would be useful but doesn't match (implement) the interface you require.
- You are designing a class, module, framework or API and you want to ensure it is usable by a wide variety of classes and applications.

### Wait a minute - do you have an example?
Ok, so imagine a standard power plug and the power outlets and the differences between US and Europe.. In between the plug and the outlet sits and "adapter" to let a US plug work with the european outlet.
The **intent** of the adapter is to convert the interface of a class into another interface the clients expect. This way it allows classes to work together that couldn't otherwise due to incompatible interfaces. It also makes client implementations "future proof", by letting them depend on adapter interfaces rather than concrete classes directly. When the underlying implementation changes for example, the client code relying on the adapter doesn't need to know about it, nor does it have to change.

### So, use it when...
- You cant to use an existing class, but it's interface doesn't match the one you require.
- You want to create a reusable class that cooperates with unrelated or unforeseen classes.
- You need to use several existing subclasses, but it's impractical to adapt their interface by subclassing each and every one.


## Resources & References
- https://app.pluralsight.com/library/courses/csharp-design-strategies/table-of-contents
- https://app.pluralsight.com/library/courses/principles-oo-design/table-of-contents
- https://app.pluralsight.com/library/courses/patterns-library/table-of-contents