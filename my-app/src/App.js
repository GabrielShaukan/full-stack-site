import './App.css';
import React from 'react';
import Entry from './Pages/Entry';
import Home from './Pages/Home';
import ChangeEntry from './Pages/ChangeEntry';
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";

export default class App extends React.Component {
  render () {
    return (
      <Router className='App'>
        <Routes>
          <Route exact path="/Entry" element={<Entry/>}  />
          <Route exact path="/" element={<Home />} />
          <Route exact path="/ChangeEntry" element={<ChangeEntry />} />
        </Routes>   
      </Router>
    )
  }
  
}

