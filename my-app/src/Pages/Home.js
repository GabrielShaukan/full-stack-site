import React, { Component } from 'react';

import Card from '../components/Card';
import * as icons from '@material-ui/icons';



export default class Home extends Component {
  
    
  render() {
    const mystyle = {
        display:'grid',
        gridTemplateColumns:'repeat(auto-fit,minmax(18rem,10rem))',
        gap:'5rem',
        justifyContent:'left',
        padding:'10rem, 10rem, 10rem, 0rem'
        
      };
      const iconStyle = {
        color:'#10657d',
        fontSize:'5rem'
      }
      
      return (
        <>
        <h1 >Arbeitsablauf</h1>
        <hr/>
        <div className="wrapper" style={mystyle}>
          <Card pageName="/Entry" title="Eingang" icon={<icons.AccountBox style={iconStyle} />}/>
          <Card pageName="/ChangeEntry" title="Umbuchung" icon={<icons.Shop style={iconStyle}/>}/>
          <Card title="Zustellung" icon={<icons.Send style={iconStyle}/>}/>
          <Card title="Abholung" icon={<icons.CallReceived style={iconStyle}/>}/>
        </div>
        <h1 >Verfolgung</h1>
        <hr/>
        <div className="wrapper" style={mystyle}>
        <Card title="Verfolgung" icon={<icons.TrackChanges style={iconStyle}/>} />
        <Card title="Rollliste" icon={<icons.List style={iconStyle} />}/>
        </div>
        <h1 >Administration</h1>
        <hr/>
        <div className="wrapper" style={mystyle}>
        <Card title="Administration" icon={<icons.Accessibility style={iconStyle}/>} />
        </div>
      </>
      );
  }
}

