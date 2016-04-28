# NLayerArchitecture_EF_Repository_UOW_AspNetMVC

Notre architecture est composée de quatre couches qui sont la couche Model, Repository, Service et Présentation. Nous allons définir le rôle de chacune de ses couches en répondant à la question (c'est quoi?) dans les lignes qui suivent:

Qu’est-ce qu’une Model Layer ?

Qu’est-ce qu’une Repository Layer ?

Qu’est-ce qu’une Service Layer ?

Business Layer (BL), aussi appelée Domain Logic, ou couche métier, Cette couche contient la logique métier de l’application. Elle sert principalement à exposer une API utilisée par la couche de présentation et à prendre à sa charge l’ensemble de l’intelligence fonctionnelle de l’application. Le reste n’est (théoriquement) que présentation et bootstrapping. Elle doit donc dialoguer avec la couche d’accès aux données (la DAL, ou Data Access Layer) afin de déclencher toutes les opérations en rapport avec la persistance des données.


Qu’est-ce qu’une Présentation Layer ?
