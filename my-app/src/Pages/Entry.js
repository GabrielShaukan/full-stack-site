import React, { Component } from 'react';
import axios from 'axios';

export default class Entry extends Component {
  state = {
    trackingnummer: 0,
    status: '',
    kepDl: '',
    handhabung: '',
    rutsche: '',
    lieferschein: ''
  }

  handleChange = (event, fieldName) => {
    this.setState({ [fieldName]: event.target.value});
  };

  handleSubmit = event => {
    event.preventDefault();
    
    axios.post('http://localhost:5000/api/packages', 
    { Status : this.state.status, 
      Handling : this.state.handhabung, 
      Chute : this.state.rutsche,
      DeliverySlip : this.state.lieferschein,
      Courier : this.state.kepDl,
      TrackingNumber : parseInt(this.state.trackingnummer) }).then(res => {
      console.log(res);
      console.log(res.data);
    })
  }

  render() {
    return (
        <>
        <form onSubmit={this.handleSubmit}>
          <label>
            Trackingnummer *
            <input type="text" name="name" onChange={(event) => this.handleChange(event, 'trackingnummer')}/>
          </label>
          <label>
            Status
            <input type="text" name="name" onChange={(event) => this.handleChange(event,'status')}/>
          </label>
          <label>
            KEP-DL *
            <input type="text" name="name" onChange={(event) => this.handleChange(event,'kepDl')}/>
          </label>
          <label>
            Handhabung
            <input type="text" name="name" onChange={(event) => this.handleChange(event,'handhabung')}/>
          </label>
          <label>
            Rutsche
            <input type="text" name="name" onChange={(event) => this.handleChange(event,'rutsche')}/>
          </label>
          <label>
            Lieferschein
            <input type="text" name="name" onChange={(event) => this.handleChange(event,'lieferschein')}/>
          </label>
          <button type="submit">Speichern</button>
        </form>
        </>
    );
  }
}
