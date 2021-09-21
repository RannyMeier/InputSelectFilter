# InputSelectFilter

https://docs.microsoft.com/en-us/dotnet/architecture/blazor-for-web-forms-developers/components

https://blazor.radzen.com/dropdown

https://github.com/dotnet/aspnetcore/blob/afacc8740c40bf465da9b9a34914a2d88d243b3c/src/Components/Web/src/Forms/InputSelect.cs

https://github.com/radzenhq/radzen-blazor/blob/master/Radzen.Blazor/DropDownBase.cs

1) Please fix Orders.razor tbody to use new InputSelectNumberFilter component for Entity and Item.
2) Like Blazor InputSelect with added search, filter, and bind to integer or string.
3) Like Radzen DropDown with integrated Search text box, virtualization, delay, and filter.
4) CSS only dropdown div contains search box and virtualized selection list.
5) Control has a textbox for up to three search terms.
6) Filter: ValStrs.Contains(term1) & ValStrs.Contains(term2) & ValStrs.Contains(term3)
7) OnInput event filters list after input time delay about 1200ms.
8) Has ability to bind to either Int32 or string in form context.
9) Display Name in select option list.
10) Filter on ValStrs property.
