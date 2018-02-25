import React from 'react'
import {Image} from 'react-bootstrap'
import banner from './bee-banner.jpg'
import {Circle} from 'rc-progress'


class UserDash extends React.PureComponent {
    constructor(props) {
        super(props);
    }

    render() {
        return(
            <React.Fragment>
            <header>
                <Image className="banner" responsive src={banner}/>
                <Circle className="progress-circle" percent="86" strokeWidth="4" strokeColor="#D3D3D3" />
            </header>
            <section>

            </section>
            </React.Fragment>
        )
    }

}

export default UserDash;