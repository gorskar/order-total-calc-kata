This implementation was based upon the Template Pattern

See https://refactoring.guru/design-patterns/template-method

The thinking was we split the "work out tax" method into a series of steps
The template contains methods for each of these steps, but specific implementations override some of these step methods
