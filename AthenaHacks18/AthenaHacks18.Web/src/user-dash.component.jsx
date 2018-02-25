import React from 'react'
import {Image} from 'react-bootstrap'


class UserDash extends React.PureComponent {
    constructor(props) {
        super(props);
    }

    render() {
        return(
            <React.Fragment>
            <header>
                <Image responsive src="./spellingbees.jpg"/>
            </header>
            <section>

            </section>
            </React.Fragment>
        )
    }

}

export default UserDash;