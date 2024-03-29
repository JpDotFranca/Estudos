﻿namespace Builder.Casa.Casa;

public interface ICasaBuilder
{
    public ICasaBuilder DefinirPiscina();
    public ICasaBuilder DefinirQuintal();
    public ICasaBuilder DefinirPorta();

    public Casa Build();
}