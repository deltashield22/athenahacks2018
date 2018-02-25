import React, { Component } from 'react';
import logo from './logo.svg';
import { Navbar, Nav, NavItem} from 'react-bootstrap'
import { Route, Link } from 'react-router-dom'
import WordExplorer from './word-explorer.component.jsx'
// import NavText from './nav-text.component.jsx'
import Login from './login.component.jsx'
import Register from './register.component.jsx'
import Main from './main.component.jsx'
import UserDash from './user-dash.component.jsx'
import './Layout.css';

class App extends Component {
  render() {
    return (
      <div>
          <div id="wrapper">
            <Navbar>
              <Navbar.Header>
                <Navbar.Brand>
                  <a href="/main">Spelling Bug</a>
                </Navbar.Brand>
                <Navbar.Toggle/>
              </Navbar.Header>
              <Navbar.Collapse>
              <Nav pullRight>
                <NavItem eventKey={1} href='/word-explorer'>
                  Word Explorer
                </NavItem>
                {/* <NavDropdown eventKey={1} title="Word Explorer" href="/word-explorer">
                </NavDropdown> */}
                <Navbar.Text>
                  <a href="/login">Login</a>
                </Navbar.Text>
              </Nav>
              </Navbar.Collapse>
            </Navbar>

            <Route exact path='/main' component={Main} />
            <Route exact path='/dashboard' component={UserDash} />
            <Route exact path='/word-explorer' component={WordExplorer} />
            <Route exact path='/login' component={Login} />
            <Route exact path='/register' component={Register} />



          </div>
        
      </div>
    );
  }
}

export default App;
