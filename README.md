# Polymorphism Example

## A simple project showing how polymorphism works

<p>We define a base class called "ShowStringBase" and a "ShowString1" class that extends the base class.</p>

### Overload example

<p>We define two methods in the derived class with different parameters. Then we call both of them and display
the different messages.</p>

### Virtual/override use

<p>We define a virtual method on the base class and then override the method on the derived class.
When we instance a derived class as a base class object and then we call the method, the overriden 
method is the one that is called.</p>


### New use

<p>We define a method on the base class and then define the method same method as "new" on the derived 
class. When we instance a derived class as a base class object and then we call the method, the base
method is the one that is called.</p>

<p>Finally, we show an example with the last instance casted to the derived class and call the method. The
one that is called is from the derived class.</p>
