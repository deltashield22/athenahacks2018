import React, { Component } from 'react';
import logo from './logo.svg';
import { Navbar, Nav, NavItem, Image } from 'react-bootstrap'
import { BrowserRouter } from 'react-router-dom'
import WordExplorer from './word-explorer.component.jsx'
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

              <WordExplorer/>
            </div>


          </div>
        </BrowserRouter>
      </div>
    );
  }
}

export default App;
