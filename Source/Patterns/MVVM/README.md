# Model-View-ViewModel (MVVM) Pattern

## History
- 2004 Martin Folwer introduced the `Presentation Model` (similar to MVP). 
  - It seperates a view from it's state and behaviour
  - Not dependent on a specific UI framework  
- 2005 John Gossman unveiled MVVM pattern
  - Variation of the MVC pattern, but tailored to new UI design. Where the view is the responsibility of a designer rather than a developer.
- 2008 John changed his mind, and realized it's the same to Martin Fowler's `Presentation Model`.

## What is it?
- Seperate concerns
  - View
  - View's state and behaviour
  - Data
- Unit testing **and** UI testing
- Maintenance
- Extensibility
- Enables the designer / developer workflow (work together more easily)
- Data binding (e.g. data binding infrastructure WPF & Silverlight) - but maybe in the future also Angular(JS). No more code behind spaghetti code ;-).

### Components
- MODEL: has **no** reference to the View or the ViewModel.
- VIEW: 
  - May or may not have a reference to the ViewModel.
  - Does **not** have a reference to the Model.
- VIEWMODEL:
  - Has a reference to the Model
  - May or mat not have a reference to the View.

### Implementation

## Resources & References
- https://app.pluralsight.com/library/courses/csharp-design-strategies/table-of-contents
- https://app.pluralsight.com/library/courses/principles-oo-design/table-of-contents
- https://app.pluralsight.com/library/courses/patterns-library/table-of-contents