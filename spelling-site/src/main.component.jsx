import React from 'react'
import { Image } from 'react-bootstrap'
// import bee from './spellingbees.jpg'

class Main extends React.PureComponent {
    constructor(props) {
        super(props);
    }

    render() {
        return (
            <React.Fragment>
                <header className="container">

                    {/* <Image responsive src={bee} /> */}
                    <h1 className="centered">Become a Spelling Bee!</h1>
                </header>
                <section>

                </section>
            </React.Fragment>
        )
    }
}

export default Main;