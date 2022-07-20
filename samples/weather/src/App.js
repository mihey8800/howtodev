import './App.css';
import { Component } from 'react'
import React from 'react';
class App extends Component {
  constructor(props) {
    super(props);
    this.state = {
      error: null,
      isLoaded: false,
      weather: null,
    }
  }

  getWeatherImageSrc(weather) {
    if (weather > 20) return 'https://c.tenor.com/JayFe1HlDzQAAAAS/good-weather-sunshine.gif';
    if (weather < 20 && weather >= 10) return 'https://c.tenor.com/3yRk6eLRiPUAAAAM/thats-normal-swift-wind.gif';
    if (weather < 10 && weather > 0) return 'https://c.tenor.com/gG50WNOE9xYAAAAM/stay-warm.gif';
    if (weather < 0) return 'https://c.tenor.com/eV8FM7HuN4oAAAAM/frozen-freezing.gif';
  }


  componentDidMount() {
    //асинхронный вызов апи
    fetch("https://api.openweathermap.org/data/2.5/weather?lat=55.0415&lon=82.9346&appid=f52ae2bc695e756e9cca1c90d486706d&lang=ru&units=metric")
      .then(res => res.json())
      .then(
        (result) => {
          this.setState({
            isLoaded: result.main ? true : false,
            weather: result.main.temp,
            error: result.main ? null : "Ошибка загрузки погоды",
          });
        },
        (error) => {
          this.setState({
            isLoaded: true,
            error
          });
        }
      )
  }

  render() {
    return (<div className="App">
      <header className="App-header">
        {this.state.weather ? this.state.weather : this.state.error}
        <img src={this.getWeatherImageSrc(this.state.weather)} alt=""/>
      </header>
    </div>)
  }
}


export default App;
