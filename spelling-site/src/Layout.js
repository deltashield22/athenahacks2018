import React, { Component } from 'react';
import logo from './logo.svg';
import { Navbar, Nav, NavItem, Image } from 'react-bootstrap'
import { BrowserRouter } from 'react-router-dom'
// import NavText from './nav-text.component.jsx'
import './Layout.css';

class App extends Component {
  render() {
    return (
      <div>
        <BrowserRouter>
          <div id="wrapper">
            <Navbar>
              <Navbar.Header>
                <Navbar.Brand>
                  <a href="home">Spelling Bug</a>
                </Navbar.Brand>
              </Navbar.Header>
              <Nav>
                <NavItem eventKey={1} href="#">
                  Link
                </NavItem>
                <Navbar.Text>
                  {/* <NavText/> */}
                </Navbar.Text>
              </Nav>
            </Navbar>

            <div className="App">

              <header >
                <Image src="https://cdn.static-economist.com/sites/default/files/images/print-edition/20170701_STP004_0.jpg" responsive/>
                <h1 className="App-title">Let's Spell!</h1>
              </header>
              <p className="App-intro">

              </p>
            </div>


          </div>
        </BrowserRouter>
      </div>
    );
  }
}

export default App;
