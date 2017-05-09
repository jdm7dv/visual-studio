<?xml version="1.0" encoding="utf-8"?>
<!-- Copyright © Microsoft Corporation.  All Rights Reserved.
This code is released under the terms of the 
Apache License, Version 2.0. Please see http://www.apache.org/licenses/LICENSE-2.0.html
-->
<!-- This profile is installed by the VSIX. In source.extension.vsixmanifest, 
     the profile's filename is listed with Custom Profile Type= Microsoft.VisualStudio.UmlProfile -->
<profile dslVersion="1.0.0.0"
       name="GoFDesignPatterns" displayName="GoF Design Patterns"
       xmlns="http://schemas.microsoft.com/UML2.1.2/ProfileDefinition">
  
  <stereotypes>

    <!-- Creational patterns -->

    <!-- Abstract Factory -->
    <stereotype name="AbstractFactory" displayName="Abstract Factory" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="AbstractProduct" displayName="Abstract Product" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>

    <!-- Builder -->
    <stereotype name="Builder" displayName="Builder" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="ConcreteBuilder" displayName="ConcreteBuilder" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="Director" displayName="Director" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>

    <!-- Factory -->
    <stereotype name="IFactory" displayName="IFactory" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IInterface" />
      </metaclasses>
    </stereotype>
    <stereotype name="Factory" displayName="Factory" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="Product" displayName="Product" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>

    <!-- Prototype -->
    <stereotype name="IPrototype" displayName="IPrototype" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IInterface" />
      </metaclasses>
    </stereotype>
    <stereotype name="ConcretePrototype" displayName="ConcretePrototype" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>

    <!-- Singleton -->
    <stereotype name="Singleton" displayName="Singleton" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
      <!--<properties>
        -->
      <!-- The static instance that holds the one instance the Singelton provides. -->
      <!--
        <property name="instance" displayName="instance" defaultValue="">
          <propertyType>
            <externalTypeMoniker name="/GoFDesignPatterns/System.String"/>
          </propertyType>
        </property>
      </properties>-->
    </stereotype>

    <!-- Object Pool -->
    <stereotype name="ReusablePool" displayName="Reusable Pool" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="Reusable" displayName="Reusable" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
   
    <!--Structural patterns-->
    
    <!--Adapter-->
    <stereotype name="Adapter" displayName="Adapter" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="Adaptee" displayName="Adaptee" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    
    <!--Bridge-->
    <stereotype name="Abstraction" displayName="Abstraction" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="RefinedAbstraction" displayName="RefinedAbstraction" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="IAbstraction" displayName="IAbstraction" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IInterface" />
      </metaclasses>
    </stereotype>
    <stereotype name="IRefinedAbstraction" displayName="IRefinedAbstraction" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IInterface" />
      </metaclasses>
    </stereotype>
    
    <!--Composite-->
    <stereotype name="Component" displayName="Component" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="Composite" displayName="Composite" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="Leaf" displayName="Leaf" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    
    <!--Decorator-->
    <stereotype name="AbstractService" displayName="AbstractService" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="ConcreteService" displayName="ConcreteService" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="AbstractWrapper" displayName="AbstractWrapper" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="ConcreteWrapper" displayName="ConcreteWrapper" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    
    <!--Façade-->
    <stereotype name="Facade" displayName="Facade" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    
    <!--Flyweight-->
    <stereotype name="AbstractFlyweight" displayName="AbstractFlyweight" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="SharedConcreteFlyweight" displayName="SharedConcreteFlyweight" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="UnsharedConcreteFlyweight" displayName="UnsharedConcreteFlyweight" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="FlyweightFactory" displayName="FlyweightFactory" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    
    <!--Iterator-->
    <stereotype name="Collection" displayName="Collection" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="IIterator" displayName="IIterator" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IInterface" />
      </metaclasses>
    </stereotype>
    <stereotype name="Iterator" displayName="Iterator" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="ICollection" displayName="ICollection" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IInterface" />
      </metaclasses>
    </stereotype>

    <!-- Behavioural patterns -->

    <!--Chain of Responsibility-->
    <stereotype name="CommandHandler" displayName="CommandHandler" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="ConcreteCommandHandler" displayName="ConcreteCommandHandler" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    
    <!--Command-->
    <stereotype name="ConcreteCommand" displayName="ConcreteCommand" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="AbstractCommand" displayName="AbstractCommand" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="CommandManager" displayName="CommandManager" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    
    <!--Interpreter-->
    <!-- Too specialised -->
    
    <!--Iterator-->
    <!-- Unnecessary - language elements cover this -->
    
    <!--Mediator-->
    <stereotype name="Colleague" displayName="Colleague" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="Mediator" displayName="Mediator" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="EventListener" displayName="EventListener" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IInterface" />
      </metaclasses>
    </stereotype>
    
    <!--Memento-->
    

    <!-- Observer -->
    <stereotype name="IObserver" displayName="IObserver" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IInterface" />
      </metaclasses>
    </stereotype>
    <stereotype name="Observer" displayName="Observer" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="IObserverable" displayName="IObserverable" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IInterface" />
      </metaclasses>
    </stereotype>
    <stereotype name="Observerable" displayName="Observerable" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="Multicaster" displayName="Multicaster" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    
    <!--State-->
    <stereotype name="Context" displayName="Context" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="ContextState" displayName="ContextState" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="ConcreteState" displayName="ConcreteState" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    
    <!--Strategy-->
    <stereotype name="IStrategy" displayName="IStrategy" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IInterface" />
      </metaclasses>
    </stereotype>
    <stereotype name="ConcreteStrategy" displayName="ConcreteStrategy" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    
    <!--Template Method-->
    <stereotype name="AbstractTemplate" displayName="AbstractTemplate" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="ConcreteTemplate" displayName="ConcreteTemplate" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>

    <!--Visitor-->
    <stereotype name="IVisitor" displayName="IVisitor" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IInterface" />
      </metaclasses>
    </stereotype>
    <stereotype name="ConcreteVisitor" displayName="ConcreteVisitor" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="Element" displayName="Element" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>
    <stereotype name="ConcreteElement" displayName="ConcreteElement" >
      <metaclasses>
        <metaclassMoniker name="/GoFDesignPatterns/Microsoft.VisualStudio.Uml.Classes.IClass" />
      </metaclasses>
    </stereotype>

  </stereotypes>
  
  <metaclasses>
    <!-- List of metaclasses (that is, classes in the UML spec) that are mentioned in the stereotype definitions. -->
    <metaclass name="Microsoft.VisualStudio.Uml.Classes.IClass"/>
    <metaclass name="Microsoft.VisualStudio.Uml.Classes.IInterface"/>
  </metaclasses>
  
  <propertyTypes>
    <!-- List of external or enumeration types that are mentioned in the stereotype property definitions. -->
    <externalType name="System.String" />
  </propertyTypes>
  
</profile>