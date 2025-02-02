class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateProvince = state;
        _country = country;
    }

    public bool IsUSA()
    {
        return _country.ToLower() == "usa";
    }

    public string GetAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
    }
}